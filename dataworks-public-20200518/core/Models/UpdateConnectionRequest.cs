// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateConnectionRequest : TeaModel {
        /// <summary>
        /// The data source ID. You can call the [ListConnections](https://help.aliyun.com/document_detail/173911.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public long? ConnectionId { get; set; }

        /// <summary>
        /// The details of the data source. Examples of details of some common data sources:
        /// 
        /// *   odps
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "accessId": "xssssss",
        ///       "accessKey": "xsaxsaxsa",
        ///       "authType": 2,
        ///       "endpoint": "http://service.odps.aliyun.com/api",
        ///       "project": "xsaxsax",
        ///       "tag": "public"
        ///     }
        /// 
        /// *   mysql
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "database": "xsaxsa",
        ///       "instanceName": "rm-xsaxsa",
        ///       "password": "xsaxsa",
        ///       "rdsOwnerId": "xasxsa",
        ///       "regionId": "cn-shanghai",
        ///       "tag": "rds",
        ///       "username": "xsaxsa"
        ///     }
        /// 
        /// *   rds
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "configType": 1,
        ///       "tag": "rds",
        ///       "database": "xsaxsa",
        ///       "username": "xsaxsa",
        ///       "password": "xssaxsa$32050",
        ///       "instanceName": "rm-xsaxs",
        ///       "rdsOwnerId": "11111111"
        ///     }
        /// 
        /// *   oss
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "accessId": "sssssxx",
        ///       "accessKey": "xsaxaxsaxs",
        ///       "bucket": "xsa-xs-xs",
        ///       "endpoint": "http://oss-cn-shanghai.aliyuncs.com",
        ///       "tag": "public"
        ///     }
        /// 
        /// *   sqlserver
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "jdbcUrl": "jdbc:sqlserver://xsaxsa-xsaxsa.database.xxx.cn:123;DatabaseName=xsxs-xsxs",
        ///       "password": "sdasda$fs",
        ///       "tag": "public",
        ///       "username": "sxaxacdacdd"
        ///     }
        /// 
        /// *   polardb
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "clusterId": "pc-sdadsadsa",
        ///       "database": "dsadsadsa",
        ///       "ownerId": "121212122",
        ///       "password": "sdasdafssa",
        ///       "region": "cn-shanghai",
        ///       "tag": "polardb",
        ///       "username": "asdadsads"
        ///     }
        /// 
        /// *   oracle
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "jdbcUrl": "jdbc:oracle:saaa:@xxxxx:1521:PROD",
        ///       "password": "sxasaxsa",
        ///       "tag": "public",
        ///       "username": "sasfadfa"
        ///     }
        /// 
        /// *   mongodb
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "address": "[\\"xsaxxsa.mongodb.rds.aliyuncs.com:3717\\"]",
        ///       "database": "admin",
        ///       "password": "sadsda@",
        ///       "tag": "public",
        ///       "username": "dsadsadas"
        ///     }
        /// 
        /// *   emr
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "accessId": "xsaxsa",
        ///       "emrClusterId": "C-dsads",
        ///       "emrResourceQueueName": "default",
        ///       "emrEndpoint": "emr.aliyuncs.com",
        ///       "accessKey": "dsadsad",
        ///       "emrUserId": "224833315798889783",
        ///       "name": "sasdsadsa",
        ///       "emrAccessMode": "simple",
        ///       "region": "cn-shanghai",
        ///       "authType": "2",
        ///       "emrProjectId": "FP-sdadsad"
        ///     }
        /// 
        /// *   postgresql
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "jdbcUrl": "jdbc:postgresql://xxxx:1921/ssss",
        ///       "password": "sdadsads",
        ///       "tag": "public",
        ///       "username": "sdsasda"
        ///     }
        /// 
        /// *   analyticdb_for_mysql
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "instanceId": "am-sadsada",
        ///       "database": "xsxsx",
        ///       "username": "xsxsa",
        ///       "password": "asdadsa",
        ///       "connectionString": "am-xssxsxs.ads.aliyuncs.com:3306"
        ///     }
        /// 
        /// *   hybriddb_for_postgresql
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "connectionString": "gp-xsaxsaxa-master.gpdbmaster.rds.aliyuncs.com",
        ///       "database": "xsaxsaxas",
        ///       "password": "xsaxsaxsa@11",
        ///       "instanceId": "gp-xsaxsaxsa",
        ///       "port": "541132",
        ///       "ownerId": "xsaxsaxsas",
        ///       "username": "sadsad"
        ///     }
        /// 
        /// *   holo
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "accessId": "xsaxsaxs",
        ///       "accessKey": "xsaxsaxsa",
        ///       "database": "xsaxsaxsa",
        ///       "instanceId": "xsaxa",
        ///       "tag": "aliyun"
        ///     }
        /// 
        /// *   kafka
        /// 
        /// <!---->
        /// 
        ///     {
        ///       "instanceId": "xsax-cn-xsaxsa",
        ///       "regionId": "cn-shanghai",
        ///       "tag": "aliyun",
        ///       "ownerId": "1212121212112"
        ///     }
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The description of the data source.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The environment in which the data source is used. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The status of the data source. Valid values: ENABLED and DISABLED. The value ENABLED indicates that the data source is in the normal state. The value DISABLED indicates that the data source is in an abnormal state.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
