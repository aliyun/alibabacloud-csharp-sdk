// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class PushWelcomeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af7***536</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1211</para>
        /// </summary>
        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://ailabsaicloudservice.alicdn.com/tmp/a.wav">http://ailabsaicloudservice.alicdn.com/tmp/a.wav</a></para>
        /// </summary>
        [NameInMap("WelcomeMusicUrl")]
        [Validation(Required=false)]
        public string WelcomeMusicUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WelcomeText")]
        [Validation(Required=false)]
        public string WelcomeText { get; set; }

    }

}
