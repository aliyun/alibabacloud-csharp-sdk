// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExportTaskDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1753858800</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成员余额变更记录_20260730.csv</para>
        /// </summary>
        [NameInMap("filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1753858860</para>
        /// </summary>
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public long? FinishedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task_xxxxxxxx</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("maxRows")]
        [Validation(Required=false)]
        public int? MaxRows { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>balance_orders</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
