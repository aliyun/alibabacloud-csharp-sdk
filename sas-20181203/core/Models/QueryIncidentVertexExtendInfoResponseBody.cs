// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexExtendInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0BCDBBF1-0048-535A-8529-67EA0CD1A807</para>
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
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The returned extended information about the node.</para>
        /// </summary>
        [NameInMap("VertexExtendInfo")]
        [Validation(Required=false)]
        public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfo> VertexExtendInfo { get; set; }
        public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1168908270980461</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// <para>The display information.</para>
            /// </summary>
            [NameInMap("DisplayInfo")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoDisplayInfo> DisplayInfo { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoDisplayInfo : TeaModel {
                /// <summary>
                /// <para>The display name of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IDA</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display value of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app:nxueo</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1377</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The language of the content within the response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:20193878</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The neighboring nodes.</para>
            /// </summary>
            [NameInMap("NeighborList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoNeighborList> NeighborList { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoNeighborList : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>Indicates whether more neighboring nodes exist. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("HasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                /// <summary>
                /// <para>The node type. Valid values include but are not limited to:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b></description></item>
                /// <item><description><b>ip</b></description></item>
                /// <item><description><b>domain</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>alidetect</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The node properties. The value is in the text format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DIRECTORY</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>The node property.</para>
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoProperty Property { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoProperty : TeaModel {
                /// <summary>
                /// <para>The alert description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exploit</para>
                /// </summary>
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                /// <summary>
                /// <para>The details of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                /// <summary>
                /// <para>The alert level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>serious</b></description></item>
                /// <item><description><b>suspicious</b></description></item>
                /// <item><description><b>remind</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>serious</para>
                /// </summary>
                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                /// <summary>
                /// <para>The alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pt_device_in_bps_down_alert</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The code of the alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6367</para>
                /// </summary>
                [NameInMap("AlertNameCode")]
                [Validation(Required=false)]
                public string AlertNameCode { get; set; }

                /// <summary>
                /// <para>The alert name. The value is in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>attack_alert</para>
                /// </summary>
                [NameInMap("AlertNameEn")]
                [Validation(Required=false)]
                public string AlertNameEn { get; set; }

                /// <summary>
                /// <para>The service that generates the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas</para>
                /// </summary>
                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                /// <summary>
                /// <para>The module of the service that generates the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aegis</para>
                /// </summary>
                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                /// <summary>
                /// <para>The alert title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>login_common_account</para>
                /// </summary>
                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                /// <summary>
                /// <para>The alert type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>attack_alert</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>The code of the alert type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112</para>
                /// </summary>
                [NameInMap("AlertTypeCode")]
                [Validation(Required=false)]
                public string AlertTypeCode { get; set; }

                /// <summary>
                /// <para>The alert type. The value is in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>attack_alert</para>
                /// </summary>
                [NameInMap("AlertTypeEn")]
                [Validation(Required=false)]
                public string AlertTypeEn { get; set; }

                /// <summary>
                /// <para>The alert ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert-abc4990f2e1948eb960a2bb7ac0****</para>
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// <para>The assets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("AssetList")]
                [Validation(Required=false)]
                public string AssetList { get; set; }

                /// <summary>
                /// <para>ATT\&amp;CK</para>
                /// 
                /// <b>Example:</b>
                /// <para>Keychain</para>
                /// </summary>
                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                /// <summary>
                /// <para>The code of the cloud service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud</para>
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// <para>The instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///       &quot;003d544744249351****&quot;
                /// ]</para>
                /// </summary>
                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public string EntityList { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-24T10:13Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-08 20:06:07</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The time when the log was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-24T10:13Z</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// <para>The log ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc4990f2e1948eb960a2bb7ac0f****</para>
                /// </summary>
                [NameInMap("LogUuid")]
                [Validation(Required=false)]
                public string LogUuid { get; set; }

                /// <summary>
                /// <para>The ID of the master account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>168370268****</para>
                /// </summary>
                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public string MainUserId { get; set; }

                /// <summary>
                /// <para>The time when the alert was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-24T10:13Z</para>
                /// </summary>
                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public string OccurTime { get; set; }

                /// <summary>
                /// <para>The ID of the sub-account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11689082709****</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the rule for which the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400035</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The time when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-06 11:00:00</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the node was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1645168444</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The node type. Valid values include but are not limited to:</para>
            /// <list type="bullet">
            /// <item><description><b>process</b></description></item>
            /// <item><description><b>file</b></description></item>
            /// <item><description><b>alert</b></description></item>
            /// <item><description><b>ip</b></description></item>
            /// <item><description><b>domain</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The node UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>678e29f4-d78f-4a7c-a2bc-38434a138538</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
