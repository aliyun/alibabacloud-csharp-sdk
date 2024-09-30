// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class CreateTagsRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>Only <c>cn-hangzhou</c> is supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The information about the tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TagKeyValueParamList")]
        [Validation(Required=false)]
        public List<CreateTagsRequestTagKeyValueParamList> TagKeyValueParamList { get; set; }
        public class CreateTagsRequestTagKeyValueParamList : TeaModel {
            /// <summary>
            /// <para>The description of the key for tag N.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business environment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The key of tag N.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Environment</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The information about the tag value.</para>
            /// </summary>
            [NameInMap("TagValueParamList")]
            [Validation(Required=false)]
            public List<CreateTagsRequestTagKeyValueParamListTagValueParamList> TagValueParamList { get; set; }
            public class CreateTagsRequestTagKeyValueParamListTagValueParamList : TeaModel {
                /// <summary>
                /// <para>The description of the value for tag N.</para>
                /// <para>Valid values of N: 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test environment</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The value of tag N.</para>
                /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. </para>
                /// <para>Valid values of N: 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
