// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class Statement : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public long? AliyunUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SELECT * FROM table</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Waiting</para>
        /// </summary>
        [NameInMap("CodeState")]
        [Validation(Required=false)]
        public string CodeState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1658987911000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Disk is full</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HaveRows")]
        [Validation(Required=false)]
        public bool? HaveRows { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Spark is running, the ouput is...</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg1</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public long? SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1658977911000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public long? StatementId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
