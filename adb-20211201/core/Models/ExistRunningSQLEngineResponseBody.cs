// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ExistRunningSQLEngineResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a running SQL engine exists in the resource group.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b></description></item>
        /// <item><description><b>False</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA675D68-14A4-5D9C-8820-92537D9F447E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
