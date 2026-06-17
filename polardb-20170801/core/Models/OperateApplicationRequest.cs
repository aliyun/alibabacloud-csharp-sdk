// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class OperateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>restart</b>: restart</description></item>
        /// <item><description><b>stop</b>: stop</description></item>
        /// <item><description><b>start</b>: start.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>restart</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

    }

}
