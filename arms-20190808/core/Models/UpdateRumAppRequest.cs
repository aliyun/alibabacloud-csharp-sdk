// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateRumAppRequest : TeaModel {
        /// <summary>
        /// Specifies whether to restart the application the next day. Valid values: true and false.
        /// </summary>
        [NameInMap("AutoRestart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// The collection configurations of the mobile SDK. You can enable or disable collection configurations based on the app version.
        /// </summary>
        [NameInMap("BonreeSDKConfigJson")]
        [Validation(Required=false)]
        public string BonreeSDKConfigJson { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether you want to subscribe to the application. Valid values: true and false.
        /// </summary>
        [NameInMap("IsSubscribe")]
        [Validation(Required=false)]
        public bool? IsSubscribe { get; set; }

        /// <summary>
        /// The alias of the application.
        /// </summary>
        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// The application ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        [NameInMap("RealRegionId")]
        [Validation(Required=false)]
        public string RealRegionId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to restart the application. Valid values: true and false.
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// The service domain name of the application. You can create, modify, and delete service domain name configurations.
        /// </summary>
        [NameInMap("ServiceDomainOperationJson")]
        [Validation(Required=false)]
        public string ServiceDomainOperationJson { get; set; }

        /// <summary>
        /// Specifies whether to stop the application. Valid values: true and false.
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

    }

}
