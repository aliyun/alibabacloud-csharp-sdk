// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryShareListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E1E63-B337-44F8-8C22-6F00DF67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the list of objects to which the work has been shared.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryShareListResponseBodyResult> Result { get; set; }
        public class QueryShareListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Sharing permissions. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>1: View only</description></item>
            /// <item><description>3: View and export</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthPoint")]
            [Validation(Required=false)]
            public int? AuthPoint { get; set; }

            /// <summary>
            /// <para>The timestamp in milliseconds indicating the expiration time of the authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640102400000</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            /// <summary>
            /// <para>The ID of the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The ID of the sharing configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ab9659e-29cf-47d7-a364-3a91553b****</para>
            /// </summary>
            [NameInMap("ShareId")]
            [Validation(Required=false)]
            public string ShareId { get; set; }

            /// <summary>
            /// <para>The ID of the sharing target, which could be a user ID or a group ID in Quick BI.</para>
            /// <list type="bullet">
            /// <item><description>When ShareToType=2 (all members within an organization), ShareToId is the organization ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
            /// </summary>
            [NameInMap("ShareToId")]
            [Validation(Required=false)]
            public string ShareToId { get; set; }

            /// <summary>
            /// <para>The name of the sharing target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareToName")]
            [Validation(Required=false)]
            public string ShareToName { get; set; }

            /// <summary>
            /// <para>The type of sharing. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>0: User</description></item>
            /// <item><description>1: Group</description></item>
            /// <item><description>2: Organization</description></item>
            /// <item><description>3: Space</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ShareToType")]
            [Validation(Required=false)]
            public int? ShareToType { get; set; }

            /// <summary>
            /// <para>The type of the shared work. The value range includes: </para>
            /// <list type="bullet">
            /// <item><description>dataProduct: Data Portal </description></item>
            /// <item><description>dashboard: Dashboard </description></item>
            /// <item><description>report: Spreadsheet </description></item>
            /// <item><description>dashboardOfflineQuery: Self-service Data Extraction </description></item>
            /// <item><description>ANALYSIS: Ad-hoc Analysis </description></item>
            /// <item><description>DATAFORM: Data Entry </description></item>
            /// <item><description>SCREEN: Data Visualization Screen</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dashboard</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
