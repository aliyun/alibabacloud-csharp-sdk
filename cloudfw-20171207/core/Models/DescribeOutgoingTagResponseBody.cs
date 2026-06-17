// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B532203E-813B-5BEB-B75B-315E1D08****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingTagResponseBodyTagList> TagList { get; set; }
        public class DescribeOutgoingTagResponseBodyTagList : TeaModel {
            /// <summary>
            /// <para>The classification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Suspicious</b>: suspicious.</para>
            /// </description></item>
            /// <item><description><para><b>Malicious</b>: malicious.</para>
            /// </description></item>
            /// <item><description><para><b>Trusted</b>: trusted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Trusted</para>
            /// </summary>
            [NameInMap("ClassId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }

            /// <summary>
            /// <para>The risk assessment level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: no threat.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: low threat.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: medium threat.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: high threat.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>The description of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test describe</para>
            /// </summary>
            [NameInMap("TagDescribe")]
            [Validation(Required=false)]
            public string TagDescribe { get; set; }

            /// <summary>
            /// <para>The ID of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-6833388d18cc****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <para>The name of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test tag</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
