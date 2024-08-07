// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportVulRequest : TeaModel {
        /// <summary>
        /// The name of the vulnerability.
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The additional type of the vulnerabilities. You need to specify this parameter when you query application vulnerabilities. If you set the Type parameter to app, you must specify this parameter. Set the value to **sca**.
        /// 
        /// > If this parameter is set to **sca**, **application vulnerabilities** and the **vulnerabilities that are detected based on software component analysis** are queried. If you do not specify this parameter, only application vulnerabilities are queried.
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// The name of the container that is affected by the vulnerability.
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// The end time of the first scan.
        /// 
        /// >  This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTsEnd")]
        [Validation(Required=false)]
        public long? CreateTsEnd { get; set; }

        /// <summary>
        /// The start time of the first scan.
        /// 
        /// >  This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTsStart")]
        [Validation(Required=false)]
        public long? CreateTsStart { get; set; }

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID of the vulnerability.
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// Specifies whether the vulnerability is fixed. Valid values:
        /// 
        /// *   **y**: The vulnerability is fixed.
        /// *   **n**: The vulnerability is not fixed.
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The server group ID of the server on which the vulnerabilities are detected.
        /// 
        /// > You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the IDs of server groups.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the image that is affected by the vulnerability.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The priority to fix the vulnerability. Separate multiple priorities with commas (,). Valid values:
        /// 
        /// *   **asap**: high
        /// *   **later**: medium
        /// *   **nntf**: low
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// The path of the process that is affected by the vulnerability.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// The tag that is used to search for the vulnerabilities. Valid values:
        /// 
        /// *   Restart required
        /// *   Remote exploitation
        /// *   Exploit exists
        /// *   Exploitable
        /// *   Privilege escalation
        /// *   Code execution
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// The type of the vulnerability that you want to export. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability
        /// *   **app**: application vulnerability
        /// *   **emg**: urgent vulnerability
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The UUID of the server on which the vulnerabilities are detected. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which the vulnerabilities are detected. Separate multiple IDs with commas (,).
        /// 
        /// > You can call the [DescribeVpcList](~~DescribeVpcList~~) operation to query the IDs of VPCs.
        /// </summary>
        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

    }

}
