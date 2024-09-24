// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCheckTypesResponseBodyData> Data { get; set; }
        public class ListCheckTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The detail of check items.</para>
            /// </summary>
            [NameInMap("CheckDetails")]
            [Validation(Required=false)]
            public List<ListCheckTypesResponseBodyDataCheckDetails> CheckDetails { get; set; }
            public class ListCheckTypesResponseBodyDataCheckDetails : TeaModel {
                /// <summary>
                /// <para>The list of the baseline categories of attribution.</para>
                /// </summary>
                [NameInMap("AffiliatedRiskTypes")]
                [Validation(Required=false)]
                public List<string> AffiliatedRiskTypes { get; set; }

                /// <summary>
                /// <para>The list of baselines attribution.</para>
                /// </summary>
                [NameInMap("AffiliatedRisks")]
                [Validation(Required=false)]
                public List<string> AffiliatedRisks { get; set; }

                /// <summary>
                /// <para>The ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                /// <summary>
                /// <para>The description of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Configure the idle session timeout period.</para>
                /// </summary>
                [NameInMap("CheckItem")]
                [Validation(Required=false)]
                public string CheckItem { get; set; }

            }

            /// <summary>
            /// <para>The type of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_integrity</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>The display name of the check item type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Integrity</para>
            /// </summary>
            [NameInMap("CheckTypeDisName")]
            [Validation(Required=false)]
            public string CheckTypeDisName { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53C0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
