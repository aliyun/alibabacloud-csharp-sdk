// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The channel type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIBER</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The contact email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        /// <summary>
        /// <para>The country code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// <para>The ID of the Facebook Business Manager (BM).</para>
        /// 
        /// <b>Example:</b>
        /// <para>393992929</para>
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
        /// <para>Specifies whether to confirm the audit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsConfirmAudit")]
        [Validation(Required=false)]
        public string IsConfirmAudit { get; set; }

        /// <summary>
        /// <para>The URL of the ISV terms file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://a.com/1.pdf">https://a.com/1.pdf</a></para>
        /// </summary>
        [NameInMap("IsvTerms")]
        [Validation(Required=false)]
        public string IsvTerms { get; set; }

        /// <summary>
        /// <para>The office address of the business.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("OfficeAddress")]
        [Validation(Required=false)]
        public string OfficeAddress { get; set; }

        /// <summary>
        /// <para>The ID of the resource group that contains the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
