// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateStrictEventNameRequest : TeaModel {
        /// <summary>
        /// <para>The list of strict mode alerts to be updated. This is a full list. Strict mode alerts not included in this list will be subjected to the opposite operation.</para>
        /// <remarks>
        /// <h2>You can call <a href="~~DescribeStrictEventName~~">DescribeStrictEventName</a> to obtain the list of all strict mode alerts.</h2>
        /// </remarks>
        /// </summary>
        [NameInMap("EventNameList")]
        [Validation(Required=false)]
        public List<string> EventNameList { get; set; }

        /// <summary>
        /// <para>Specifies the language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies the action to perform on the alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><em>on</em>: enables alerts.</description></item>
        /// <item><description><em>off</em>: disables alerts.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
