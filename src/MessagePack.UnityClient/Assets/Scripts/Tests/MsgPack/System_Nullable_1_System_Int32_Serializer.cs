﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sandbox.Shared.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Nullable_1_System_Int32_Serializer : MsgPack.Serialization.MessagePackSerializer<System.Nullable<int>> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        public System_Nullable_1_System_Int32_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
        }
        
        protected override void PackToCore(MsgPack.Packer packer, System.Nullable<int> objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected override System.Nullable<int> UnpackFromCore(MsgPack.Unpacker unpacker) {
            return new System.Nullable<int>(this._serializer0.UnpackFrom(unpacker));
        }
    }
}