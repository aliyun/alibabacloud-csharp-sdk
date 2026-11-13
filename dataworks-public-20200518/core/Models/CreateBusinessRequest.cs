// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateBusinessRequest : TeaModel {
        /// <summary>
        /// <para>The name of the workflow. The name must be unique within the same workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My business process</para>
        /// </summary>
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// <para>The description of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a business process created through an interface.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the owner of the workflow. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and move the pointer over the profile picture in the upper-right corner of the top menu bar to view the account ID. If this parameter is left empty, the Alibaba Cloud account ID of the caller is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to view the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the workspace name. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to view the name. You must specify either this parameter or the ProjectId parameter to determine the DataWorks project for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The functional module to which the workflow belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Data Studio.</description></item>
        /// <item><description>MANUAL_BIZ: Manual workflow.</description></item>
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
