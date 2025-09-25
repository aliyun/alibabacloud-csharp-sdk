// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateAuthKeyRequest : TeaModel {
        /// <summary>
        /// <para>When the Test flag is false or empty, AuthYears is required, in years, with a range of [1,100]. A value of 100 indicates permanent authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthYears")]
        [Validation(Required=false)]
        public int? AuthYears { get; set; }

        /// <summary>
        /// <para>Business type. No more than 64 characters. Can be used to note specific business, such as different face usage scenarios of the access party or the customer identifier to be delivered. It is recommended to pass this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_TEST</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Test flag. If true, it indicates using test authorization with a default duration of 30 days; if false, the authorization duration will be based on AuthYears.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Test")]
        [Validation(Required=false)]
        public bool? Test { get; set; }

        /// <summary>
        /// <para>User device ID. No more than 64 characters. Can be used to identify a specific device, and it is suggested to use the physical number of the device. It is recommended to pass this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3iJ1AY$oHcu7mC69</para>
        /// </summary>
        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
