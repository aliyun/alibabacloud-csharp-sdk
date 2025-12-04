// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVmsVirtualNumberRelationByPageRequest : TeaModel {
        /// <summary>
        /// <para>号码归属地--城市</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("NumberCity")]
        [Validation(Required=false)]
        public string NumberCity { get; set; }

        /// <summary>
        /// <para>号码归属地--省</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("NumberProvince")]
        [Validation(Required=false)]
        public string NumberProvince { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>74</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>81</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>真实号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>131***1234</para>
        /// </summary>
        [NameInMap("RealNumber")]
        [Validation(Required=false)]
        public string RealNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>状态 1:有效；0:无效；-1:注销</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public long? State { get; set; }

        /// <summary>
        /// <para>虚拟号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571****1234</para>
        /// </summary>
        [NameInMap("VirtualNumber")]
        [Validation(Required=false)]
        public string VirtualNumber { get; set; }

    }

}
