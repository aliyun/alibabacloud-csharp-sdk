// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListServiceInstanceForPageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>服务实例号</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571****1234</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Pager")]
        [Validation(Required=false)]
        public string PagerShrink { get; set; }

        /// <summary>
        /// <para>关联实体号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****1111</para>
        /// </summary>
        [NameInMap("RelationNumber")]
        [Validation(Required=false)]
        public string RelationNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>场景ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>用途ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>89</para>
        /// </summary>
        [NameInMap("UsageId")]
        [Validation(Required=false)]
        public long? UsageId { get; set; }

    }

}
