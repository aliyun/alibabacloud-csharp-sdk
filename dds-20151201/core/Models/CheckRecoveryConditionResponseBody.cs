// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckRecoveryConditionResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1378****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>Indicates whether the data of the instance can be restored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The data of the instance can be restored.</description></item>
        /// <item><description><b>false</b>: The data of the instance cannot be restored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsValid")]
        [Validation(Required=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D563A3E7-6010-45FE-A0CD-9283414C9657</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
