// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ExecuteBatchTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_PBKTxxx</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disagree</para>
        /// </summary>
        [NameInMap("OutResult")]
        [Validation(Required=false)]
        public string OutResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hexxxx</para>
        /// </summary>
        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;taskId&quot;:&quot;2291xxx&quot;,&quot;formInstId&quot;:&quot;d84a79xxx&quot;}, {&quot;taskId&quot;:&quot;2291xxx&quot;,&quot;formInstId&quot;:&quot;f8035e2axxx&quot;}]</para>
        /// </summary>
        [NameInMap("TaskInformationList")]
        [Validation(Required=false)]
        public string TaskInformationList { get; set; }

    }

}
