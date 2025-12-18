// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateCompliancePackRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of the account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-f632626622af0079****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The ID of the compliance package.</para>
        /// <para>For more information about how to obtain the ID of a compliance package, see <a href="https://help.aliyun.com/document_detail/262059.html">ListAggregateCompliancePacks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-fdc8626622af00f9****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>You can add up to 20 tags to a resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public List<GetAggregateCompliancePackRequestTag> Tag { get; set; }
        public class GetAggregateCompliancePackRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys.</para>
            /// <para>The tag key cannot be an empty string. The tag key must be 1 to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs</c>:. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag values.</para>
            /// <para>The tag values can be an empty string or up to 128 characters in length. The tag values cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each key-value must be unique. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
