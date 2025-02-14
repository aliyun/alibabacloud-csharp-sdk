// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateStrictEventNameRequest : TeaModel {
        /// <summary>
        /// <para>List of strict alarms to be operated on. This list is a complete list, and any strict alarms not included in this list will have the opposite operation performed.</para>
        /// <remarks>
        /// <h2>You can call <a href="~~DescribeStrictEventName~~">DescribeStrictEventName</a> to get the list of all strict mode alarms.</h2>
        /// </remarks>
        /// </summary>
        [NameInMap("EventNameList")]
        [Validation(Required=false)]
        public List<string> EventNameList { get; set; }

        /// <summary>
        /// <para>Sets the language type for requests and received messages, default is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Operation rule determination operator:</para>
        /// <list type="bullet">
        /// <item><description><em>on</em>: Turn on the alarm</description></item>
        /// <item><description><em>off</em>: Turn off the alarm</description></item>
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
