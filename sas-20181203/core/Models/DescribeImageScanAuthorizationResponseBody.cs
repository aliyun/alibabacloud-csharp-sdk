// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageScanAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization status of image scans.</para>
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public DescribeImageScanAuthorizationResponseBodyAuthStatus AuthStatus { get; set; }
        public class DescribeImageScanAuthorizationResponseBodyAuthStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether Security Center is authorized to scan images. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes </description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340D7FC4-D575-1661-8ACD-CFA7BE57****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
