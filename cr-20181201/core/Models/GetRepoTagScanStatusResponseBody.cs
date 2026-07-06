// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagScanStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Specifies whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC648259-91A7-4502-BED3-EDF64361FA83</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scan engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ACR_SCAN_SERVICE</c>: the ACR Trivy scan engine.</para>
        /// </description></item>
        /// <item><description><para><c>SAS_SCAN_SERVICE</c>: the Cloud Security scan engine.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACR_SCAN_SERVICE</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        /// <summary>
        /// <para>The scan status of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SCANNING</c>: The image is being scanned.</para>
        /// </description></item>
        /// <item><description><para><c>COMPLETE</c>: The scan is complete.</para>
        /// </description></item>
        /// <item><description><para><c>FAILED</c>: The scan failed.</para>
        /// </description></item>
        /// <item><description><para><c>RETRYING</c>: The scan is being retried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
