// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Contact the administrator.</para>
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INNER_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataSourceResponseBodyData> Data { get; set; }
        public class ListDataSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cluster_name</para>
            /// </summary>
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ConnExtraAttributes")]
            [Validation(Required=false)]
            public object ConnExtraAttributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T20:27:28.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T20:37:28.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e_4w****v</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx.xxx.xxx.1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RATION***1DBUTF11</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OperatingSystem")]
            [Validation(Required=false)]
            public string OperatingSystem { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("OracleNlsLengthSemantics")]
            [Validation(Required=false)]
            public string OracleNlsLengthSemantics { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("OracleSid")]
            [Validation(Required=false)]
            public string OracleSid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public string PartnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2883</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>178641****05809</para>
            /// </summary>
            [NameInMap("ResourceOwner")]
            [Validation(Required=false)]
            public string ResourceOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MASTER</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>schema_name</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tenant_name</para>
            /// </summary>
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>+08:00</para>
            /// </summary>
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MYSQL_PUBLIC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user_name</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4.1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc_t4***</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ListDataSourceResponseBodyErrorDetail ErrorDetail { get; set; }
        public class ListDataSourceResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CM-RESOAT1111</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A system error occurred.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A system error occurred.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
