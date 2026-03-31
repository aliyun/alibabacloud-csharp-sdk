// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregatorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The account groups.</para>
        /// </summary>
        [NameInMap("AggregatorsResult")]
        [Validation(Required=false)]
        public ListAggregatorsResponseBodyAggregatorsResult AggregatorsResult { get; set; }
        public class ListAggregatorsResponseBodyAggregatorsResult : TeaModel {
            /// <summary>
            /// <para>The list of the account groups.</para>
            /// </summary>
            [NameInMap("Aggregators")]
            [Validation(Required=false)]
            public List<ListAggregatorsResponseBodyAggregatorsResultAggregators> Aggregators { get; set; }
            public class ListAggregatorsResponseBodyAggregatorsResultAggregators : TeaModel {
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
                /// <para>The number of member accounts in the account group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AggregatorAccountCount")]
                [Validation(Required=false)]
                public long? AggregatorAccountCount { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the account group was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1623036305000</para>
                /// </summary>
                [NameInMap("AggregatorCreateTimestamp")]
                [Validation(Required=false)]
                public long? AggregatorCreateTimestamp { get; set; }

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
                /// <item><description>0: The account group is being created.</description></item>
                /// <item><description>1: The account group was created.</description></item>
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
                /// <item><description>RD: global account group.</description></item>
                /// <item><description>FOLDER: account group of the folder.</description></item>
                /// <item><description>CUSTOM: custom account group.</description></item>
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
                /// <para>Example-description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-BU****</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>tags</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListAggregatorsResponseBodyAggregatorsResultAggregatorsTags> Tags { get; set; }
                public class ListAggregatorsResponseBodyAggregatorsResultAggregatorsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag keys of the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-1</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag values of the resource.</para>
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
            /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TGlzdFJlc291cmNlU2hhcmVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20C8526D-12C5-4336-BC72-EBD5D1BA732F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
