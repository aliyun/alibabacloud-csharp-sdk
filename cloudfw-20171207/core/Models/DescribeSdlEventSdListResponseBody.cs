// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlEventSdListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SdlEventSensitiveDataList")]
        [Validation(Required=false)]
        public List<DescribeSdlEventSdListResponseBodySdlEventSensitiveDataList> SdlEventSensitiveDataList { get; set; }
        public class DescribeSdlEventSdListResponseBodySdlEventSensitiveDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-N***************************SxiJ</para>
            /// </summary>
            [NameInMap("SensitiveData")]
            [Validation(Required=false)]
            public string SensitiveData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SensitiveDataCnt")]
            [Validation(Required=false)]
            public long? SensitiveDataCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S3</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            [NameInMap("SensitiveType")]
            [Validation(Required=false)]
            public string SensitiveType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.23.191.XXX</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1753928907</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
