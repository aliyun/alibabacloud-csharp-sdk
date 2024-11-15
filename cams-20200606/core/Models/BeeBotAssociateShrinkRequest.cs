// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotAssociateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of a bot instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChatBotInstanceId")]
        [Validation(Required=false)]
        public string ChatBotInstanceId { get; set; }

        /// <summary>
        /// <para>The space ID of the user within the independent software vendor (ISV) account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The ISV verification code, which is used to verify whether the user is authorized by ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ksiekdki39ksks93939</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The list of codes for answers from different perspectives.</para>
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public string PerspectiveShrink { get; set; }

        /// <summary>
        /// <para>The number of recommended questions. The value ranges from 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RecommendNum")]
        [Validation(Required=false)]
        public int? RecommendNum { get; set; }

        /// <summary>
        /// <para>The ID of the session, which is used to identify the session and store context information in the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2334324234</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The input of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
