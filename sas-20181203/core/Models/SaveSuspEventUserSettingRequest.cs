// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveSuspEventUserSettingRequest : TeaModel {
        /// <summary>
        /// <para>The data source of the exception. Set the value to sas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The severities of alert notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>remind</b></description></item>
        /// <item><description><b>suspicious</b></description></item>
        /// <item><description><b>serious</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>suspicious,serious,remind</para>
        /// </summary>
        [NameInMap("LevelsOn")]
        [Validation(Required=false)]
        public string LevelsOn { get; set; }

    }

}
