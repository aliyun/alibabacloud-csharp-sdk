// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateBusinessRequest : TeaModel {
        /// <summary>
        /// <para>Name of the Business Process.<br>
        /// The name must be unique within the same project space.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My business process</para>
        /// </summary>
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// <para>Description of the Business Process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the owner responsible for the Business Process.<br>
        /// You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, move the mouse pointer over the profile picture in the upper-right corner of the menu bar, and view the Account ID. If this parameter is empty, the Alibaba Cloud account ID of the invoker is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.<br>
        /// You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Workspace Management page, and view the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the English identifier displayed when you switch workspaces at the top of the Data Development page. You must specify either this parameter or the projectid parameter to identify the DataWorks project for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>Function module to which the Business Process belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NORMAL (Data Development)</para>
        /// </description></item>
        /// <item><description><para>MANUAL_BIZ (manually triggered workflow)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("UseType")]
        [Validation(Required=false)]
        public string UseType { get; set; }

    }

}
