// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The email address of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:123@alibaba.com">123@alibaba.com</a></para>
        /// </summary>
        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        /// <summary>
        /// <para>The country code ID.</para>
        /// <remarks>
        /// <para>For detailed country codes, refer to <a href="https://help.aliyun.com/document_detail/608210.html">Country codes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// <para>fb bmId</para>
        /// 
        /// <b>Example:</b>
        /// <para>393998****</para>
        /// </summary>
        [NameInMap("FacebookBmId")]
        [Validation(Required=false)]
        public string FacebookBmId { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ins</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance ID, which uniquely identifies the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82838838****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>viber_ins</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically confirm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsConfirmAudit")]
        [Validation(Required=false)]
        public string IsConfirmAudit { get; set; }

        /// <summary>
        /// <para>The ISV/client agreement file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aa.com/a.pdf">https://aa.com/a.pdf</a></para>
        /// </summary>
        [NameInMap("IsvTerms")]
        [Validation(Required=false)]
        public string IsvTerms { get; set; }

        /// <summary>
        /// <para>The enterprise address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("OfficeAddress")]
        [Validation(Required=false)]
        public string OfficeAddress { get; set; }

    }

}
