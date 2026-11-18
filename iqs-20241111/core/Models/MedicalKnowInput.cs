// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MedicalKnowInput : TeaModel {
        /// <summary>
        /// <para>The medical, drug, disease, or food entity whose properties are to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Amoxicillin Capsules</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The entity query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>finding: disease</description></item>
        /// <item><description>food: food</description></item>
        /// <item><description>medicine: medicine
        /// If this parameter is not specified, the type is automatically identified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medicine</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
