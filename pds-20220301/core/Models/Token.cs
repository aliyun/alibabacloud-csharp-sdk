// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Token : TeaModel {
        /// <summary>
        /// <para>The access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VySWQiOiJjOWI3YTVhYTA0ZDE0YWUzODY3ZmRjODg2ZmEwMWRhNCIsImN1c3RvbUpzb24iOiJ7XCJjbGllbnRJZFwiOlwiMjVkelgzdmJZcWt0Vnh5WFwiLFwiZG9tYWluSWRcIjpcImJqMjlcIixcInNjb3BlXCI6W1wiRFJJVkUuQUxMXCIsXCJTSEFSRS5BTExcIixcIkZJTEUuQUxMXCIsXCJVU0VSLkFMTFwiLFwiVklFVy5BTExcIixcIlNUT1JBR0UuQUxMXCIsXCJTVE9SQUdFRklMRS5MSVNUXCIsXCJCQVRDSFwiLFwiT0FVVEguQUxMXCIsXCJJTUFHRS5BTExcIixcIklOVklURS5BTExcIixcIkFDQ09VTlQuQUxMXCJdLFwicm9sZVwiOlwidXNlclwiLFwicmVmXCI6XCJodHRwczovL3d3dy5hbGl5dW5kcml2ZS5jb20vXCIsXCJkZXZpY2VfaWRcIjpcImIyODIwNWU1YzU5NzRjY2JiODI3MDNiNjhkYjhjNDUxXCJ9IiwiZXhwIjoxNjQ4NjE0NDkzLCJpYXQiOjE2NDg2MDcyMzN9.d3HVLvv_LFw2QhPrhvjH_kICWQJX9sKKt7NjQEqI_xE2JO_b7D8rPsFTZz93PLvZ7MhCmudTjGImUpd-ehFnI4Go-1S7BGaKaHFILvP-sWy18Wpikowjxx9mSbzBM_cO6D1LI-kyYhXKWHgVdADfVIPniTDA7-ffhUpi7cAebEs</para>
        /// </summary>
        [NameInMap("access_token")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The profile picture of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunpds.com/a.jpg</para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The ID of the default space of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("default_drive_id")]
        [Validation(Required=false)]
        public string DefaultDriveId { get; set; }

        [NameInMap("default_sbox_drive_id")]
        [Validation(Required=false)]
        public string DefaultSboxDriveId { get; set; }

        /// <summary>
        /// <para>The name of the device that is bound to OAuth 2.0 Device Authorization Grant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4683C25F</para>
        /// </summary>
        [NameInMap("device_name")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("exist_link")]
        [Validation(Required=false)]
        public List<LinkInfo> ExistLink { get; set; }

        /// <summary>
        /// <para>The time when the credential expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-01T06:57:48.813Z</para>
        /// </summary>
        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The validity period of the token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// <para>Indicates whether this is the first logon of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_first_login")]
        [Validation(Required=false)]
        public bool? IsFirstLogin { get; set; }

        [NameInMap("need_link")]
        [Validation(Required=false)]
        public bool? NeedLink { get; set; }

        [NameInMap("need_rp_verify")]
        [Validation(Required=false)]
        public bool? NeedRpVerify { get; set; }

        /// <summary>
        /// <para>The nickname of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsuser</para>
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("pin_setup")]
        [Validation(Required=false)]
        public bool? PinSetup { get; set; }

        /// <summary>
        /// <para>The refresh token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>060e78d36afb4879b51e4264e9541c16</para>
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>The role of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The status of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the token.</para>
        /// <list type="bullet">
        /// <item><description>Only Bearer is supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Bearer</para>
        /// </summary>
        [NameInMap("token_type")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

        [NameInMap("user_data")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserData { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING-xxxxx</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The name of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsuser</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
