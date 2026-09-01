// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RunNotifyComponentWithEmailRequest : TeaModel {
        /// <summary>
        /// <para>The name of the component action.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notifyByCustom</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// <para>The ID of the asset that is used to send the email.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeComponentAssets~~">DescribeComponentAssets</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The name of the playbook component.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotifyMessage</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The body of the email.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>email content</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the playbook node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notify_message_1</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e99dab31-499b-4307-9248-xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>A list of email addresses.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Receivers")]
        [Validation(Required=false)]
        public List<string> Receivers { get; set; }

        /// <summary>
        /// <para>The UID of the member whose data an administrator wants to access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137602xxx718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts that belong to the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>The title of the email.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
