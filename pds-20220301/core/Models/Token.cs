// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Token : TeaModel {
        [NameInMap("access_token")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("default_drive_id")]
        [Validation(Required=false)]
        public string DefaultDriveId { get; set; }

        [NameInMap("device_id")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("device_name")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        [NameInMap("is_first_login")]
        [Validation(Required=false)]
        public bool? IsFirstLogin { get; set; }

        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("token_type")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
