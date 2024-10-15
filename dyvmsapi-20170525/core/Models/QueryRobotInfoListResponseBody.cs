// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotInfoListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The basic information about the robot, in the JSON format. The basic information contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>id</b>: the robot ID.</description></item>
        /// <item><description><b>robotName</b>: the robot name.</description></item>
        /// <item><description><b>robotType</b>: the robot type.</description></item>
        /// <item><description><b>auditStatus</b>: the review state.</description></item>
        /// <item><description><b>gmtCreate</b>: the time when the task was created.</description></item>
        /// <item><description><b>gmtModified</b>: the time when the task was modified.</description></item>
        /// <item><description><b>partnerId</b>: the partner ID.</description></item>
        /// <item><description><b>asrId</b>: the ID of the automatic speech recognition (ASR) model.</description></item>
        /// <item><description><b>asrType</b>: the ASR type. Valid values: <b>Public</b> and <b>Private</b>.</description></item>
        /// <item><description><b>remark</b>: the additional information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{[&quot;id&quot;:1000010920004, &quot;gmtModified&quot;:&quot;Thu Mar 21 15:38:55 CST 2019&quot;, &quot;auditStatus&quot;:&quot;AUDITPASS&quot;,&quot;gmtCreate&quot;:&quot;Thu Mar 21 12:00:51 CST 2019&quot;,&quot;remark&quot;:&quot;tset&quot;,&quot;partnerId&quot;:100000022670001,&quot;asrId&quot;:&quot;a9a1d69081fd4266ad788346bf5e1b6c&quot;,&quot;robotType&quot;:&quot;CUSTOM&quot;,&quot;asrType&quot;:&quot;1&quot;,&quot;robotName&quot;:&quot;Collection scenario&quot;},{&quot;id&quot;:1000010920003,&quot;gmtModified&quot;:&quot;Thu Mar 21 11:51:10 CST 2019&quot;,&quot;auditStatus&quot;:&quot;AUDITPASS&quot;,&quot;gmtCreate&quot;:&quot;Thu Mar 21 11:44:57 CST 2019&quot;,&quot;remark&quot;:&quot;test&quot;,&quot;partnerId&quot;:100000022670001,&quot;asrId&quot;:&quot;a9a1d69081fd4266ad788346bf5e1b6c&quot;,&quot;robotType&quot;:&quot;CUSTOM&quot;,&quot;asrType&quot;:&quot;1&quot;,&quot;robotName&quot;:&quot;Collection scenario&quot;]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F59AF338-655D-48E8-9471-5EB07692B1CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
