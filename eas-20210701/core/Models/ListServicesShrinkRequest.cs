// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServicesShrinkRequest : TeaModel {
        /// <summary>
        /// {
        ///   "RequestId": "40325405-579C-4D82-9624-EC2B1779848E",
        ///   "Services": [
        ///     {
        ///       "ServiceId": "200516454695942578",
        ///       "ServiceName": "vipserver",
        ///       "ParentUid": "1628454689805075",
        ///       "CallerUid": "eas",
        ///       "CurrentVersion": 1,
        ///       "Cpu": 1,
        ///       "Gpu": 0,
        ///       "Memory": 900,
        ///       "Image": "registry.cn-zhangjiakou.aliyuncs.com/eas/ndisearch_v1_inner_zhangbei:v0.0.3-20200302145109",
        ///       "Resource": "seccontent_inner_2080ti_5",
        ///       "Namespace": "vipserver",
        ///       "CreateTime": "2019-10-25T10:37:53Z",
        ///       "UpdateTime": "2019-10-30T16:50:59Z",
        ///       "TotalInstance": 1,
        ///       "RunningInstance": 1,
        ///       "PendingInstance": 0,
        ///       "LatestVersion": 1,
        ///       "Status": "Running",
        ///       "Reason": "RUNNING",
        ///       "Message": "Service is now scaling",
        ///       "AccessToken": "",
        ///       "Weight": 0
        ///     },
        ///     {
        ///       "ServiceId": 97097,
        ///       "ServiceName": "a1",
        ///       "CallerUid": "eas",
        ///       "CurrentVersion": 1,
        ///       "Cpu": 1,
        ///       "Gpu": 0,
        ///       "Memory": 900,
        ///       "Image": "registry.cn-hangzhou.aliyuncs.com/eas/pi_imemb_tb:v0.0.1-20191023130701",
        ///       "Resource": "seccontent_inner_b",
        ///       "Namespace": "a1",
        ///       "CreateTime": "2020-05-26T18:03:11Z",
        ///       "UpdateTime": "2020-05-26T18:03:11Z",
        ///       "TotalInstance": 1,
        ///       "RunningInstance": 0,
        ///       "PendingInstance": 1,
        ///       "LatestVersion": 1,
        ///       "Status": "Failed",
        ///       "Reason": "FAILED",
        ///       "Message": "the server could not find the requested resource (post services.meta.k8s.io)",
        ///       "AccessToken": "regression_test_token",
        ///       "Weight": 0
        ///     }
        ///   ],
        ///   "PageNumber": 1,
        ///   "PageSize": 2,
        ///   "TotalCount": 2
        /// }
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string LabelShrink { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// 376577
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ParentServiceUid")]
        [Validation(Required=false)]
        public string ParentServiceUid { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("ServiceUid")]
        [Validation(Required=false)]
        public string ServiceUid { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
