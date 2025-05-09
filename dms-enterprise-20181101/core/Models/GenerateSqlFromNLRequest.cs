// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GenerateSqlFromNLRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1***</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Dialect")]
        [Validation(Required=false)]
        public string Dialect { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>state&gt;0代表成功</para>
        /// </summary>
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

    }

}
