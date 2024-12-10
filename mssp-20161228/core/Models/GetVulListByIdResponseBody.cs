// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetVulListByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>API response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetVulListByIdResponseBodyData> Data { get; set; }
        public class GetVulListByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Vulnerability Alias</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tomcat websocket 拒绝服务漏洞利用代码披露（CVE-2020-13935）</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>Impact description</para>
            /// </summary>
            [NameInMap("EffectMsgDTOS")]
            [Validation(Required=false)]
            public List<GetVulListByIdResponseBodyDataEffectMsgDTOS> EffectMsgDTOS { get; set; }
            public class GetVulListByIdResponseBodyDataEffectMsgDTOS : TeaModel {
                /// <summary>
                /// <para>Hit</para>
                /// 
                /// <b>Example:</b>
                /// <para>fastjson(jar) extendField.safemode equals false</para>
                /// </summary>
                [NameInMap("MatchList")]
                [Validation(Required=false)]
                public string MatchList { get; set; }

                /// <summary>
                /// <para>Path</para>
                /// 
                /// <b>Example:</b>
                /// <para>/uat6/qry/enquiry/policy/yrtPolicyList</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Software name</para>
                /// 
                /// <b>Example:</b>
                /// <para>python-perf 3.10.0</para>
                /// </summary>
                [NameInMap("SoftName")]
                [Validation(Required=false)]
                public string SoftName { get; set; }

            }

            /// <summary>
            /// <para>Timestamp of the first time the vulnerability was detected</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620404763000</para>
            /// </summary>
            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public string FirstTs { get; set; }

            /// <summary>
            /// <para>Instance name of the asset</para>
            /// 
            /// <b>Example:</b>
            /// <para>凌星-CentOS</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Public IP of the asset</para>
            /// 
            /// <b>Example:</b>
            /// <para>39.101.73.28</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>Private IP of the asset</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.22.216.17</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>Timestamp of the last time the vulnerability was detected</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620404763000</para>
            /// </summary>
            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public string LastTs { get; set; }

            /// <summary>
            /// <para>Vulnerability name</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCA:ACSV-2020-111301</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Necessity level of vulnerability repair</para>
            /// 
            /// <b>Example:</b>
            /// <para>later,asap,nntf</para>
            /// </summary>
            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// <para>List of associated CVEs for the vulnerability, separated by commas (,) if there are multiple values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2020-13935</para>
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// <para>Repair command</para>
            /// 
            /// <b>Example:</b>
            /// <para>*** update python-perf</para>
            /// </summary>
            [NameInMap("RepairCmd")]
            [Validation(Required=false)]
            public string RepairCmd { get; set; }

            /// <summary>
            /// <para>Timestamp of vulnerability repair</para>
            /// 
            /// <b>Example:</b>
            /// <para>1541207563000</para>
            /// </summary>
            [NameInMap("RepairTs")]
            [Validation(Required=false)]
            public string RepairTs { get; set; }

            /// <summary>
            /// <para>Vulnerability status:
            /// 1: Not fixed
            /// 2: Fix failed
            /// 3: Rollback failed
            /// 4: Fixing
            /// 5: Rolling back
            /// 6: Verifying
            /// 7: Fixed successfully
            /// 8: Fixed successfully, pending reboot
            /// 9: Rolled back successfully
            /// 10: Ignored
            /// 11: Rolled back successfully, pending reboot
            /// 12: Vulnerability does not exist
            /// 20: Expired</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Vulnerability tag</para>
            /// 
            /// <b>Example:</b>
            /// <para>Restart Required</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdm_5cf2eaf263c021b354877943f181956d</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Prompt message for the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetVulListByIdResponseBodyPageInfo PageInfo { get; set; }
        public class GetVulListByIdResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number of items per page in the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D38B3D2F-67FD-57FF-87D1-C431D2C70F76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Values: - <b>true</b>: Yes. - <b>false</b>: No.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
