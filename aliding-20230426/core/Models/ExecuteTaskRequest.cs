// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ExecuteTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APP_PBKT0MFBEBTDO8T7SLVP</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http://</para>
        /// </summary>
        [NameInMap("DigitalSignUrl")]
        [Validation(Required=false)]
        public string DigitalSignUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("FormDataJson")]
        [Validation(Required=false)]
        public string FormDataJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>y</para>
        /// </summary>
        [NameInMap("NoExecuteExpressions")]
        [Validation(Required=false)]
        public string NoExecuteExpressions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AGREE</para>
        /// </summary>
        [NameInMap("OutResult")]
        [Validation(Required=false)]
        public string OutResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530</para>
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hexxyy</para>
        /// </summary>
        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12002575L</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
