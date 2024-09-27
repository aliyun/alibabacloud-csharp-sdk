// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ListFoCreatedAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about disaster recovery plans.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFoCreatedAppsResponseBodyData> Data { get; set; }
        public class ListFoCreatedAppsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>应用ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>JIX9NEZUALGS46UI</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The URL of an error report.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://api.aliyun.com/troubleshoot?q=ServiceUnavailable&product=BPStudio&requestId=4CDA03A3-C652-1408-8ABD-7E652A7CBFB6">https://api.aliyun.com/troubleshoot?q=ServiceUnavailable&amp;product=BPStudio&amp;requestId=4CDA03A3-C652-1408-8ABD-7E652A7CBFB6</a></para>
            /// </summary>
            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }

            /// <summary>
            /// <para>The status of the disaster recovery plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed_Success
            /// Destroyed_Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, a success message is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cannot find region according to your domain.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40F63F07-3AB6-53B3-8825-0580C130E3EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
