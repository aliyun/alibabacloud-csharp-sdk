// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class InvokeFunctionRequest : TeaModel {
        /// <summary>
        /// 事件（event），binary type。函数计算服务将event传递给用户function来处理
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public byte[] Body { get; set; }

        /// <summary>
        /// service版本, 可以是versionId或者aliasName
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
