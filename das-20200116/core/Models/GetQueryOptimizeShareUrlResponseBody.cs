// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeShareUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The share URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://hdm.console.aliyun.com/#/queryOptimize?Keywords=&OnlyOptimizedSql=true&Time=1684771200000&Engine=MySQL&InstanceIds=&Rules=&PageNo=1&PageSize=10&OrderBy=count&Asc=false&SqlIds=&dbNames=&region=cn-china&user=">https://hdm.console.aliyun.com/#/queryOptimize?Keywords=&amp;OnlyOptimizedSql=true&amp;Time=1684771200000&amp;Engine=MySQL&amp;InstanceIds=&amp;Rules=&amp;PageNo=1&amp;PageSize=10&amp;OrderBy=count&amp;Asc=false&amp;SqlIds=&amp;dbNames=&amp;region=cn-china&amp;user=</a></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, Successful is returned. If the request failed, an error message that contains information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
