// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class Adb4MysqlSparkDiagnosisInfo : TeaModel {
        /// <summary>
        /// <para>The diagnostic code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task_long_tail</para>
        /// </summary>
        [NameInMap("DiagnosisCode")]
        [Validation(Required=false)]
        public string DiagnosisCode { get; set; }

        /// <summary>
        /// <para>The diagnostic cause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The query execution duration is long.</para>
        /// </summary>
        [NameInMap("DiagnosisCodeLabel")]
        [Validation(Required=false)]
        public string DiagnosisCodeLabel { get; set; }

        /// <summary>
        /// <para>The diagnostic suggestion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Check the query execution plan and optimize the SQL.</para>
        /// </summary>
        [NameInMap("DiagnosisMsg")]
        [Validation(Required=false)]
        public string DiagnosisMsg { get; set; }

        /// <summary>
        /// <para>The diagnostic information type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPLICATION</para>
        /// </summary>
        [NameInMap("DiagnosisType")]
        [Validation(Required=false)]
        public string DiagnosisType { get; set; }

    }

}
