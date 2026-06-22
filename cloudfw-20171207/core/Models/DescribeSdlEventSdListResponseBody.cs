// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlEventSdListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of sensitive data involved in data leaks.</para>
        /// </summary>
        [NameInMap("SdlEventSensitiveDataList")]
        [Validation(Required=false)]
        public List<DescribeSdlEventSdListResponseBodySdlEventSensitiveDataList> SdlEventSensitiveDataList { get; set; }
        public class DescribeSdlEventSdListResponseBodySdlEventSensitiveDataList : TeaModel {
            /// <summary>
            /// <para>The sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-N***************************SxiJ</para>
            /// </summary>
            [NameInMap("SensitiveData")]
            [Validation(Required=false)]
            public string SensitiveData { get; set; }

            /// <summary>
            /// <para>The number of occurrences of the sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SensitiveDataCnt")]
            [Validation(Required=false)]
            public long? SensitiveDataCnt { get; set; }

            /// <summary>
            /// <para>The level of the sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S3</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The type of the sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id_card</para>
            /// </summary>
            [NameInMap("SensitiveType")]
            [Validation(Required=false)]
            public string SensitiveType { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.23.191.XXX</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <para>The start time. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753928907</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
