// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetDetailByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>404</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDetailByIdResponseBodyData Data { get; set; }
        public class GetDetailByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Vulnerability details.</para>
            /// </summary>
            [NameInMap("VulDetails")]
            [Validation(Required=false)]
            public List<GetDetailByIdResponseBodyDataVulDetails> VulDetails { get; set; }
            public class GetDetailByIdResponseBodyDataVulDetails : TeaModel {
                /// <summary>
                /// <para>CVE ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CVE-2022-21291</para>
                /// </summary>
                [NameInMap("CveId")]
                [Validation(Required=false)]
                public string CveId { get; set; }

                /// <summary>
                /// <para>The CVSS score of the vulnerability in the Alibaba Cloud vulnerability database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("CvssScore")]
                [Validation(Required=false)]
                public string CvssScore { get; set; }

                /// <summary>
                /// <para>Fix suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://avd.aliyun.com/detail/CVE-2022-21291">https://avd.aliyun.com/detail/CVE-2022-21291</a></para>
                /// </summary>
                [NameInMap("FixSuggestion")]
                [Validation(Required=false)]
                public string FixSuggestion { get; set; }

                /// <summary>
                /// <para>Title of the vulnerability announcement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chanjet T-Plus SetupAccount/Upload. Aspx file upload vulnerability(CNVD-2022-60632)</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

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
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAB46EC5-3746-59C4-B6D2-469F442EC73F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Values: - <b>true</b>: indicates a successful call. - <b>false</b>: indicates a failed call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
