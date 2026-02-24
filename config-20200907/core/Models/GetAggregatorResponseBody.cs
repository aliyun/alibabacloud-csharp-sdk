// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregatorResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the account group.</para>
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public GetAggregatorResponseBodyAggregator Aggregator { get; set; }
        public class GetAggregatorResponseBodyAggregator : TeaModel {
            /// <summary>
            /// <para>The ID of the management account that is used to create the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The number of members in the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AggregatorAccountCount")]
            [Validation(Required=false)]
            public long? AggregatorAccountCount { get; set; }

            /// <summary>
            /// <para>The information about the members in the account group.</para>
            /// </summary>
            [NameInMap("AggregatorAccounts")]
            [Validation(Required=false)]
            public List<GetAggregatorResponseBodyAggregatorAggregatorAccounts> AggregatorAccounts { get; set; }
            public class GetAggregatorResponseBodyAggregatorAggregatorAccounts : TeaModel {
                /// <summary>
                /// <para>The member ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>171322098523****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The member name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>false</c>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The type of the account. Only ResourceDirectory is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ResourceDirectory</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The status of Resource Monitoring for the member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>REGISTRABLE: Not registered.</para>
                /// </description></item>
                /// <item><description><para>BUILDING: Building.</para>
                /// </description></item>
                /// <item><description><para>REGISTERED: Registered.</para>
                /// </description></item>
                /// <item><description><para>REBUILDING: Rebuilding.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>REGISTERED</para>
                /// </summary>
                [NameInMap("RecorderStatus")]
                [Validation(Required=false)]
                public string RecorderStatus { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the account group was created.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623034091000</para>
            /// </summary>
            [NameInMap("AggregatorCreateTimestamp")]
            [Validation(Required=false)]
            public string AggregatorCreateTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-88ea626622af0055****</para>
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// <para>The name of the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test_Group</para>
            /// </summary>
            [NameInMap("AggregatorName")]
            [Validation(Required=false)]
            public string AggregatorName { get; set; }

            /// <summary>
            /// <para>The status of the account group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The account group is being created.</para>
            /// </description></item>
            /// <item><description><para>1: The account group is created.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AggregatorStatus")]
            [Validation(Required=false)]
            public int? AggregatorStatus { get; set; }

            /// <summary>
            /// <para>The type of the account group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RD: global account group.</para>
            /// </description></item>
            /// <item><description><para>FOLDER: folder account group.</para>
            /// </description></item>
            /// <item><description><para>CUSTOM: custom account group.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("AggregatorType")]
            [Validation(Required=false)]
            public string AggregatorType { get; set; }

            /// <summary>
            /// <para>The description of the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the aggregator.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the folder to which the folder account group is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-brHdgv****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The name of the folder to which the folder account group is attached. Multiple names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example-name</para>
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            /// <summary>
            /// <para>The resource tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAggregatorResponseBodyAggregatorTags> Tags { get; set; }
            public class GetAggregatorResponseBodyAggregatorTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value-1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>733DD93C-2277-4905-AE0C-0BA95C04B8BC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
