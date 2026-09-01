// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response.</para>
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
        /// <para>The UUID of the second published version for comparison.</para>
        /// <remarks>
        /// <para>To obtain the UUID of a historical version, call the <a href="~~DescribePlaybookReleases~~">DescribePlaybookReleases</a> operation. The system automatically generates a UUID for a new version.</para>
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
        /// <para>The UUID of the first published version for comparison.</para>
        /// <remarks>
        /// <para>To obtain the UUID of a historical version, call the <a href="~~DescribePlaybookReleases~~">DescribePlaybookReleases</a> operation. The system automatically generates a UUID for a new version.</para>
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
        /// <para>Call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain this parameter.</para>
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
