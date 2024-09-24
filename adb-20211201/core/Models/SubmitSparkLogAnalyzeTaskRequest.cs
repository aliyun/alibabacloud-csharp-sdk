// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SubmitSparkLogAnalyzeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Spark application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s202301121553hzd9c6f7xxxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
