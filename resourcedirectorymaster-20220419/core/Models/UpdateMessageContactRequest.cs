// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class UpdateMessageContactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-qL4HqKONzOM7****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>The email address of the contact.</para>
        /// <para>After you specify an email address, you need to call <a href="~~SendEmailVerificationForMessageContact~~">SendEmailVerificationForMessageContact</a> to send verification information to the email address. After the verification is passed, the email address takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>someone***@example.com</para>
        /// </summary>
        [NameInMap("EmailAddress")]
        [Validation(Required=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// <para>The types of messages received by the contact.</para>
        /// </summary>
        [NameInMap("MessageTypes")]
        [Validation(Required=false)]
        public List<string> MessageTypes { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tom</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the contact.</para>
        /// <para>Specify the mobile phone number in the <c>&lt;Country code&gt;-&lt;Mobile phone number&gt;</c> format.</para>
        /// <para>After you specify a mobile phone number, you need to call <a href="~~SendPhoneVerificationForMessageContact~~">SendPhoneVerificationForMessageContact</a> to send verification information to the mobile phone number. After the verification is passed, the mobile phone number takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86-139****1234</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The job title of the contact.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>FinanceDirector</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>TechnicalDirector</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>MaintenanceDirector</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CEO</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>ProjectDirector</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Other</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TechnicalDirector</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
