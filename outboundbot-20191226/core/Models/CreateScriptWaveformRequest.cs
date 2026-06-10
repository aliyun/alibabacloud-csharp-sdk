// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateScriptWaveformRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the recording file.</para>
        /// <remarks>
        /// <para>Obtain this ID from the Folder parameter of the GetJobDataUploadParams operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6f91885fa24b4c408d8f4eb392fd8ae6</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The name of the recording file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>faaf8508-9542-4ac4-84a2-0ddcbb5f79a6 (2).json</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2bfa5ae4-7185-4227-a3b8-328f26f11be1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The text of the script.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您好，您昨晚在李佳琦直播间下单的娜薇诗椰子水二代精华2支装还未付款，超时未支付会自动关闭订单，活动错过不再有奥。</para>
        /// </summary>
        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public string ScriptContent { get; set; }

        /// <summary>
        /// <para>Scenario ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c5d8c0-c0f1-48a7-be2b-dc46006d888a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
