// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of field codes for export columns. This parameter is optional and applies only to WUYING_SERVER_LIST. Do not pass this parameter for other task types. You can pass up to 100 elements. The codes are case-sensitive. Leading and trailing spaces in fields are removed, and blank elements are ignored. Duplicate codes are retained in the order of their first appearance. WuyingServerId is always the first column, and the remaining columns are exported in the order specified in the request. If this parameter is not passed, only WuyingServerId is exported.</para>
        /// <para>Supported codes: WuyingServerId, WuyingServerName, Status, BizRegionId, ZoneId, OfficeSiteId, ServerInstanceType, ServerInstanceTypeId, Cpu, Memory, Image, OsType, ImageId, SystemDisk, DataDisks, NetworkInterfaceIp, PrivateIpSets, SecurityGroupIds, Bandwidth, ChargeType, SubPayType, VirtualNodePool, CreateTime, ExpiredTime, and VirtualKubeletInfo.</para>
        /// <para>In the original RPC request, pass the parameters sequentially as ExportFields.1, ExportFields.2, and so on. For example, ExportFields.1=WuyingServerId and ExportFields.2=Status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;WuyingServerId&quot;,&quot;Status&quot;]</para>
        /// </summary>
        [NameInMap("ExportFields")]
        [Validation(Required=false)]
        public List<string> ExportFields { get; set; }

        /// <summary>
        /// <para>The JSON string serialized from the query condition object. This parameter is required and cannot be an empty string. Field names must use the following lower camel case format.</para>
        /// <list type="bullet">
        /// <item><description>WUYING_SERVER_LIST: If no filter condition is specified, pass the JSON string corresponding to {}. Only wuyingServerIdList, wuyingServerNameOrId, status, bizRegionId, zoneId, officeSiteId, serverInstanceType, imageId, chargeType, virtualNodePoolId, addVirtualNodePoolStatusList, users, networkInterfaceIp, createTimeStart, createTimeEnd, expiredTimeStart, and expiredTimeEnd are supported. The semantics of each field are the same as those in ListWuyingServer. Pagination or other unlisted fields cannot be passed. The values of wuyingServerIdList, addVirtualNodePoolStatusList, and users must be serialized into JSON array strings before the outer query object is serialized.</description></item>
        /// <item><description>BROWSER_BOOKMARK_LIST and BROWSER_RESTRICTED_URL_LIST: The object must and can only contain browserInstanceGroupId, and the value must be a non-empty cloud browser delivery group ID string. It cannot contain Keyword, pagination, or other fields.</description></item>
        /// <item><description>USER_USAGE_REPORT: Use productType, startDate, and endDate to specify the product type and query time range. You can use appInstanceGroupId, bizRegionId, userId, and connectionStatus for filtering. startDate and endDate must be in the yyyy-MM-dd HH:mm:ss format. Query parameters are parsed and verified during the asynchronous execution phase. A successful creation does not mean that all these query conditions have passed verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bizRegionId&quot;:&quot;cn-hangzhou&quot;,&quot;zoneId&quot;:&quot;cn-hangzhou-h&quot;}</para>
        /// </summary>
        [NameInMap("QueryParamJson")]
        [Validation(Required=false)]
        public string QueryParamJson { get; set; }

        /// <summary>
        /// <para>The type of the export task. This parameter is required and case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WUYING_SERVER_LIST: WUYING server list.</description></item>
        /// <item><description>USER_USAGE_REPORT: User usage report.</description></item>
        /// <item><description>BROWSER_BOOKMARK_LIST: Cloud browser bookmark list.</description></item>
        /// <item><description>BROWSER_RESTRICTED_URL_LIST: Cloud browser URL whitelist.</description></item>
        /// </list>
        /// <para>Different task types use different QueryParamJson query conditions. Only WUYING_SERVER_LIST supports selecting export columns by using ExportFields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WUYING_SERVER_LIST</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
