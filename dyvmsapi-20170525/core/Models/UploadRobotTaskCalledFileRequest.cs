// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class UploadRobotTaskCalledFileRequest : TeaModel {
        /// <summary>
        /// <para>The called numbers. Separate multiple called numbers with commas (,).</para>
        /// <remarks>
        /// <para>After you create a robocall task, you must upload called numbers in batches. You can upload up to 300,000 called numbers for each task.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1370<b><b>000,1370</b></b>111</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The unique ID of the robocall task. You can call the <a href="~~CreateRobotTask~~">CreateRobotTask</a> operation to obtain the ID of the robocall task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1045****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The values of the variable in the text-to-speech (TTS) template, in the JSON format. The variable values specified by the TtsParam parameter must match the variable names specified by the TtsParamHead parameter.</para>
        /// <list type="bullet">
        /// <item><description>If all the called numbers carry the same variable values, you can set the value of the number field to <b>all</b> and upload only one copy of the variable values.</description></item>
        /// <item><description>If only some of the called numbers carry the same variable values, you can set the value of the number field to <b>all</b> for these called numbers and set the value of the number field and variable values for other called numbers based on your business requirements. The system preferentially selects the values that you set for the called numbers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;number&quot;:&quot;1370****000&quot;,&quot;params&quot;:[&quot;xiaowang&quot;,&quot;xiaoli&quot;,&quot;xiaozhou&quot;]}]</para>
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// <para>The list of variable names carried in the robocall task, in the JSON format. The TtsParamHead parameter must be used together with the TtsParam parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;name1&quot;,&quot;name2&quot;,&quot;name3&quot;]</para>
        /// </summary>
        [NameInMap("TtsParamHead")]
        [Validation(Required=false)]
        public string TtsParamHead { get; set; }

    }

}
