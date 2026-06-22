// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateStrictEventNameRequest : TeaModel {
        /// <summary>
        /// <para>The list of strict mode alerts to operate on. This is a full list. Strict mode alerts not included in this list will have the opposite action applied.</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeStrictEventName~~">DescribeStrictEventName</a> to obtain the list of all strict mode alerts.
        /// -.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EventNameList")]
        [Validation(Required=false)]
        public List<string> EventNameList { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
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
        /// <para>The operator for the rule action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><em>on</em>: enables alerting</description></item>
        /// <item><description><em>off</em>: disables alerting.</description></item>
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
