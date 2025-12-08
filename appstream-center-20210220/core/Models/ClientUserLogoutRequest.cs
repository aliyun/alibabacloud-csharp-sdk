// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210220.Models
{
    public class ClientUserLogoutRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eac19bef-1e45-4190-a03a-4ea74b****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v22369636c721ba6b3ddb1683341016775c3f63e4d0e78f120f9a0544ed826b7af7daf747c402f0d0730b52f451b70****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hongkong+dir-643067****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn_hangzhou</para>
        /// </summary>
        [NameInMap("ProfileRegion")]
        [Validation(Required=false)]
        public string ProfileRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>597e869d-ea14-4b83-9490-714f68****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
