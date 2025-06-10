// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagScanStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
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
        /// <item><description><c>false</c>: The request fails.</description></item>
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
        /// <para>The type of the scanning engine.</para>
        /// <list type="bullet">
        /// <item><description><c>ACR_SCAN_SERVICE</c>: Trivy scan engine provided by Container Registry</description></item>
        /// <item><description><c>SAS_SCAN_SERVICE</c>: Security Center scan engine</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACR_SCAN_SERVICE</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        /// <summary>
        /// <para>The scanning status of the image tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>SCANNING</c>: The image tag is being scanned.</description></item>
        /// <item><description><c>COMPLETE</c>: The scanning of the image tag is complete.</description></item>
        /// <item><description><c>FAILED</c>: The image tag failed to be scanned.</description></item>
        /// <item><description><c>RETRYING</c>: The system is retrying to scan the image tag.</description></item>
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
