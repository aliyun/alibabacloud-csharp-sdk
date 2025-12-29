// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListServiceInstanceForPageRequest : TeaModel {
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
        public ListServiceInstanceForPageRequestPager Pager { get; set; }
        public class ListServiceInstanceForPageRequestPager : TeaModel {
            /// <summary>
            /// <para>当前页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }

            /// <summary>
            /// <para>每页数量，默认10，最大100</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

        }

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
