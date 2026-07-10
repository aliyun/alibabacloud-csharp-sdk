// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateAuthKeyRequest : TeaModel {
        /// <summary>
        /// <para>The authorization duration. This parameter is required when the Test parameter is set to false or is left empty. Unit: years. Valid values: 1 to 100. A value of 100 indicates permanent authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthYears")]
        [Validation(Required=false)]
        public int? AuthYears { get; set; }

        /// <summary>
        /// <para>The business type. The value can be up to 64 characters in length. You can use this parameter to add remarks for a specific business, such as different facial recognition scenarios of the requester or the customer identifier to be delivered. We recommend that you specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_TEST</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The test identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Uses test authorization. The authorization duration is 30 days by default.</description></item>
        /// <item><description>false: The authorization duration is determined by the AuthYears parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Test")]
        [Validation(Required=false)]
        public bool? Test { get; set; }

        /// <summary>
        /// <para>The user device ID. The value can be up to 64 characters in length. You can use this parameter to identify a specific device. We recommend that you use the physical device number. We recommend that you specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3iJ1AY$oHcu7mC69</para>
        /// </summary>
        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
