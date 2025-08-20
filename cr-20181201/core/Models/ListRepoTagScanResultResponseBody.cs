// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagScanResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56B5C92F-F5D9-46E0-823F-EC71D1892DAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of vulnerabilities detected on images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>196</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The details about the detected vulnerabilities.</para>
        /// </summary>
        [NameInMap("Vulnerabilities")]
        [Validation(Required=false)]
        public List<ListRepoTagScanResultResponseBodyVulnerabilities> Vulnerabilities { get; set; }
        public class ListRepoTagScanResultResponseBodyVulnerabilities : TeaModel {
            /// <summary>
            /// <para>The ID of the image layer where the vulnerability was detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:123456717b8e40b6480979b739010d8d549989602bcdd07922119aec6f9dbe57</para>
            /// </summary>
            [NameInMap("AddedBy")]
            [Validation(Required=false)]
            public string AddedBy { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Vulnerability</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            [Obsolete]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The URL of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://security-tracker.debian.org/tracker/CVE-2009-5155">https://security-tracker.debian.org/tracker/CVE-2009-5155</a></para>
            /// </summary>
            [NameInMap("CveLink")]
            [Validation(Required=false)]
            public string CveLink { get; set; }

            /// <summary>
            /// <para>The directory of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test.txt</para>
            /// </summary>
            [NameInMap("CveLocation")]
            [Validation(Required=false)]
            public string CveLocation { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2009-5155</para>
            /// </summary>
            [NameInMap("CveName")]
            [Validation(Required=false)]
            public string CveName { get; set; }

            /// <summary>
            /// <para>The description of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The cause of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eglibc</para>
            /// </summary>
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// <para>The command used to fix the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yum install -y xxx</para>
            /// </summary>
            [NameInMap("FixCmd")]
            [Validation(Required=false)]
            public string FixCmd { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cve</c>: image system vulnerability</description></item>
            /// <item><description><c>sca</c>: image application vulnerability</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The severity of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Medium</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The version of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.19-6.9</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The version where the vulnerability was fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.19-18+deb8u5</para>
            /// </summary>
            [NameInMap("VersionFixed")]
            [Validation(Required=false)]
            public string VersionFixed { get; set; }

            /// <summary>
            /// <para>The format of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dpkg</para>
            /// </summary>
            [NameInMap("VersionFormat")]
            [Validation(Required=false)]
            public string VersionFormat { get; set; }

        }

    }

}
