// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the second version.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybookReleases~~">DescribePlaybookReleases</a> operation to query the IDs of versions. The system automatically generates IDs for new versions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sfdf2395-e814-459f-9662-xxxxx</para>
        /// </summary>
        [NameInMap("NewPlaybookReleaseId")]
        [Validation(Required=false)]
        public int? NewPlaybookReleaseId { get; set; }

        /// <summary>
        /// <para>The ID of the first version.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybookReleases~~">DescribePlaybookReleases</a> operation to query the IDs of versions. The system automatically generates IDs for new versions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sflk23423-e814-459f-9662-xxxxx</para>
        /// </summary>
        [NameInMap("OldPlaybookReleaseId")]
        [Validation(Required=false)]
        public int? OldPlaybookReleaseId { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a>operation to query the UUIDs of playbooks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f916b93e-e814-459f-9662-xxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
