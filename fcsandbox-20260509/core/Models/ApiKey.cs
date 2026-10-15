// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class ApiKey : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34f6a4c4-499f-4bbd-baa0-0e699f53abcd</para>
        /// </summary>
        [NameInMap("apiKeyID")]
        [Validation(Required=false)]
        public string ApiKeyID { get; set; }

        /// <summary>
        /// <para>The display value of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2b_xxxx****xxxx</para>
        /// </summary>
        [NameInMap("apiKeyMask")]
        [Validation(Required=false)]
        public string ApiKeyMask { get; set; }

        /// <summary>
        /// <para>The name of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The value of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2b_xxxxxx79cd777ef8exxxxxx4ad6f1b567cxxxxxx</para>
        /// </summary>
        [NameInMap("apiKeyValue")]
        [Validation(Required=false)]
        public string ApiKeyValue { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-13T08:27:20Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-13T08:27:20Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The list of IP addresses that are prohibited from using the API key.</para>
        /// </summary>
        [NameInMap("ipBlacklist")]
        [Validation(Required=false)]
        public List<IPConfig> IpBlacklist { get; set; }

        /// <summary>
        /// <para>The list of IP addresses that are allowed to use the API key.</para>
        /// </summary>
        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        public List<IPConfig> IpWhitelist { get; set; }

        /// <summary>
        /// <para>The last used time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-14T08:27:20Z</para>
        /// </summary>
        [NameInMap("lastUsedTime")]
        [Validation(Required=false)]
        public string LastUsedTime { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwxqyrgwabcd</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The source of the API key.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active</description></item>
        /// <item><description>inactive</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0383-58d8-97ac-5336eb91abcd</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The name of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Development team</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <para>The plan of the team to which the API key belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pro</para>
        /// </summary>
        [NameInMap("teamPlan")]
        [Validation(Required=false)]
        public string TeamPlan { get; set; }

        /// <summary>
        /// <para>The UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
