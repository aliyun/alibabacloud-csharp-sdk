// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the alarm event.</para>
        /// <remarks>
        /// <para>If querying the anomaly information of a single alarm event, you need to provide the unique ID of the alarm event, which can be obtained by calling the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8df914418f4211fb****</para>
        /// </summary>
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        /// <summary>
        /// <para>Indicates whether the online processing of exceptions is supported, such as blocking an exception, adding an exception to the whitelist, and ignoring an exception. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The online processing of exceptions is supported.</description></item>
        /// <item><description><b>false</b>: The online processing of exceptions is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanBeDealOnLine")]
        [Validation(Required=false)]
        public bool? CanBeDealOnLine { get; set; }

        /// <summary>
        /// <para>The data source of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aegis_suspicious_****</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>An array that consists of the details of the exception.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeSuspEventDetailResponseBodyDetails> Details { get; set; }
        public class DescribeSuspEventDetailResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>The display name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Trojan Path</para>
            /// </summary>
            [NameInMap("NameDisplay")]
            [Validation(Required=false)]
            public string NameDisplay { get; set; }

            /// <summary>
            /// <para>The format in which the details of the exception are displayed.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b></description></item>
            /// <item><description><b>html</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>html</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The attribute information about the exception. For example, if the exception is associated with an alert that is triggered by an unusual logon, the information can include the time when the logon is initiated and the location from which the logon is initiated. If the exception is associated with an alert that is triggered by a webshell file, the information can include the path of the trojan file and the type of the trojan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>getopt</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The detection model found a suspicious Webshell file on your server, which may be a backdoor file implanted to maintain permissions after the attacker successfully invaded the website.</para>
        /// </summary>
        [NameInMap("EventDesc")]
        [Validation(Required=false)]
        public string EventDesc { get; set; }

        /// <summary>
        /// <para>The name of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The status of the exception. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: pending handling</description></item>
        /// <item><description><b>2</b>: ignored</description></item>
        /// <item><description><b>4</b>: confirmed</description></item>
        /// <item><description><b>8</b>: marked as a false positive</description></item>
        /// <item><description><b>16</b>: handling</description></item>
        /// <item><description><b>32</b>: handled</description></item>
        /// <item><description><b>64</b>: expired</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        /// <summary>
        /// <para>The type of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Malicious Software-Variable Trojan</para>
        /// </summary>
        [NameInMap("EventTypeDesc")]
        [Validation(Required=false)]
        public string EventTypeDesc { get; set; }

        /// <summary>
        /// <para>The ID of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11416624</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// <para>The name of the server on which the exception was detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_cpm_****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The public IP address of the server on which the exception was detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.132.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The private IP address of the server on which the exception was detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.26.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The time when the exception was last detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-30 11:43:46</para>
        /// </summary>
        [NameInMap("LastTime")]
        [Validation(Required=false)]
        public string LastTime { get; set; }

        /// <summary>
        /// <para>The risk level of the exception. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serious</b></description></item>
        /// <item><description><b>suspicious</b></description></item>
        /// <item><description><b>remind</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The code that indicates the handling result of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quara.Succes</para>
        /// </summary>
        [NameInMap("OperateErrorCode")]
        [Validation(Required=false)]
        public string OperateErrorCode { get; set; }

        /// <summary>
        /// <para>The message that indicates the handling result of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("OperateMsg")]
        [Validation(Required=false)]
        public string OperateMsg { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The edition of Security Center in which the exception can be detected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Basic edition</description></item>
        /// <item><description><b>1</b>: Advanced edition</description></item>
        /// <item><description><b>2</b>: Enterprise edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SaleVersion")]
        [Validation(Required=false)]
        public string SaleVersion { get; set; }

        /// <summary>
        /// <para>The UUID of the server on which the exception was detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bffb12c3-590a-4db2-b538-****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
