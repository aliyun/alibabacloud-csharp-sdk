// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAppsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the applications.</para>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultAppName</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>Region id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The installation/uninstallation status of the application.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTALLFAILED: The application failed to be installed.</description></item>
        /// <item><description>UNINSTALLING: The application is being uninstalled.</description></item>
        /// <item><description>INSTALLING: The application is being installed.</description></item>
        /// <item><description>UNINSTALLED: The application is uninstalled.</description></item>
        /// <item><description>INSTALLED: The application is installed.</description></item>
        /// <item><description>UNINSTALLFAILED: The application failed to be uninstalled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INSTALLING</para>
        /// </summary>
        [NameInMap("InstallationStatus")]
        [Validation(Required=false)]
        public string InstallationStatus { get; set; }

        /// <summary>
        /// <para>The value of MD5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>THCIEH73KEK3334</para>
        /// </summary>
        [NameInMap("MD5")]
        [Validation(Required=false)]
        public string MD5 { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the parameter is left empty, the data is queried from the first entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status of the application.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FAILED: The application failed to be created.</description></item>
        /// <item><description>NORMAL: The application is available.</description></item>
        /// <item><description>CREATING: The application is being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
