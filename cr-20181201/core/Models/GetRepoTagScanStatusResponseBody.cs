// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagScanStatusResponseBody : TeaModel {
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
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The API call succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The API call failed.</para>
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
        /// <item><description><c>ACR_SCAN_SERVICE</c>: The ACR Trivy scan engine.</description></item>
        /// <item><description><c>SAS_SCAN_SERVICE</c>: The cloud security scan engine.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACR_SCAN_SERVICE</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        /// <summary>
        /// <para>The scan status of the image version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SCANNING</c>: Scanning.</para>
        /// </description></item>
        /// <item><description><para><c>COMPLETE</c>: Completed.</para>
        /// </description></item>
        /// <item><description><para><c>FAILED</c>: Failed.</para>
        /// </description></item>
        /// <item><description><para><c>RETRYING</c>: Retrying.</para>
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
